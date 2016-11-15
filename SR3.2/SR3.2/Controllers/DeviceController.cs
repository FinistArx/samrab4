using SamRab3_2.Models.Contex;
using SR3._2.Models.Device;
using SR3._2.Models.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace SR3._2.Controllers
{
    public class DeviceController : Controller
    {
        private SmartHomeContex bb = new SmartHomeContex();
        public ActionResult Index()
        {
            IList<AbstractDevice> list = new List<AbstractDevice>();

            foreach (AbstractDevice item in bb.Boilers.ToList())
            {
                list.Add(item);
            }
            foreach (AbstractDevice item in bb.Conds.ToList())
            {
                list.Add(item);
            }
            foreach (AbstractDevice item in bb.Fredges.ToList())
            {
                list.Add(item);
            }
            foreach (AbstractDevice item in bb.TVs.ToList())
            {
                list.Add(item);
            }
            foreach (AbstractDevice item in bb.MCs.ToList())
            {
                list.Add(item);
            }

            SelectListItem[] appList = new SelectListItem[5];
            appList[0] = new SelectListItem { Text = "Грелко", Value = "boiler", Selected = true };
            appList[1] = new SelectListItem { Text = "Студилко", Value = "cond" };
            appList[2] = new SelectListItem { Text = "Едасхрон", Value = "fridge" };
            appList[3] = new SelectListItem { Text = "Контробасс", Value = "musik" };
            appList[4] = new SelectListItem { Text = "Телик", Value = "tvset" };
            ViewBag.AppList = appList;

            return View(list);
        }


        public ActionResult Add(string deviceType)
        {
            AbstractDevice newDevice;
            switch (deviceType)
            {
                case "tvset":
                    newDevice = new TV(false, 100, 50);
                    break;
                case "musik":
                    newDevice = new MC(false, 100, 50);
                    break;
                case "boiler":
                    newDevice = new Conditioner(false, 40, 10, 18);
                    break;
                case "cond":
                    newDevice = new Boiler(false, 90, 10, 15);
                    break;
                default:
                    newDevice = new Fridge(false, 20, -18, 0, false);
                    break;
            }

            int id = (int)Session["NextId"];
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            SmartHome.Add(id, newDevice);
            id++;
            Session["NextId"] = id;

            return RedirectToAction("Index");
        }

        public ActionResult OnOff(int id)
        {
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            ((AbstractDevice)SmartHome[id]).OnOff();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            SmartHome.Remove(id);
            return RedirectToAction("Index");
        }

        public ActionResult OpenClose(int id)
        {
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            ((IOpenClose)SmartHome[id]).OpCl();

            return RedirectToAction("Index");
        }

        public ActionResult TempIncrease(int id)
        {
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            ((Temperature)SmartHome[id]).IncreaseTemp();

            return RedirectToAction("Index");
        }

        public ActionResult TempDecrease(int id)
        {
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            ((Temperature)SmartHome[id]).DecreaseTemp();

            return RedirectToAction("Index");
        }

        public ActionResult VolumeIncr(int id)
        {
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            ((IVolume)SmartHome[id]).IncreaseVolume();

            return RedirectToAction("Index");
        }
        public ActionResult VolumeDecr(int id)
        {
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            ((IVolume)SmartHome[id]).DecreaseVolume();

            return RedirectToAction("Index");
        }

        public ActionResult OniOffi(int id)
        {
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            SmartHome[id].OnOff();

            return RedirectToAction("Index");
        }

        public ActionResult NextChenell(int id)
        {
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            ((IChangeChennel)SmartHome[id]).NextChennel();

            return RedirectToAction("Index");
        }
        public ActionResult PrevChenell(int id)
        {
            IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
            ((IChangeChennel)SmartHome[id]).PreviusChennel();

            return RedirectToAction("Index");
        }

        //[Route("api/values/one")]
        //public Boiler GetOne()
        //{
        //    Boiler bobo = new Boiler { false, 40, 10, 18 };
        //    return bobo;
        //}

    }
}