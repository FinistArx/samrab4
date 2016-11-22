using SamRab3_2.Models.Contex;
using SR3._2.Models.Contex;
using SR3._2.Models.Device;
using SR3._2.Models.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SR3._2.Controllers
{
    public class DeviceController : Controller
    {
        private SmartHomeContex bb = new SmartHomeContex();
        private TemperatureContex tc = new TemperatureContex();
        private VolumeContex vc = new VolumeContex();
        private ChennelContex cc = new ChennelContex();
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
            appList[0] = new SelectListItem { Text = "Жароед", Value = "boiler" };
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
                    newDevice = new Boiler(false, 23);
                    break;
                case "cond":
                    newDevice = new Conditioner(false, 20);
                    break;
                default:
                    newDevice = new Fridge(false, -5, false);
                    break;
            }

            bb.Devices.Add(newDevice);
            bb.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult OnOff(int id)
        {
            AbstractDevice z = bb.Devices.Find(id);
            if (z != null)
            {
                z.OnOff();
                bb.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            AbstractDevice b = bb.Devices.Find(id);
            if (b != null)
            {
                bb.Devices.Remove(b);
                bb.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult OpenClose(int id)
        {
            Fridge opcl = bb.Fredges.Find(id);
            if (opcl != null)
            {
                opcl.OpCl();
                bb.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult TempIncrease(string deviceType)
        {
            IRegulatorTemp newtemp = tc.Tempes.Find(deviceType);
            if (newtemp != null)
            {
                switch (deviceType)
                {
                    case "boiler":
                        newtemp.IncreaseTemp();
                        break;
                    case "cond":
                        newtemp.DecreaseTemp();
                        break;
                    default:
                        newtemp.IncreaseTemp();
                        break;
                }
                tc.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult TempDecrease(string deviceType)
        {
            Temperature newtemp2 = bb.Boilers.Find(deviceType);
            if (newtemp2 != null)
            {
                switch (deviceType)
                {
                    case "boiler":
                        newtemp2.DecreaseTemp();
                        break;
                    case "cond":
                        newtemp2.DecreaseTemp();
                        break;
                    default:
                        newtemp2.DecreaseTemp();
                        break;
                }

                tc.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult VolumeIncr(string deviceType)
        {
            IVolume newvol = vc.TVs.Find(deviceType);
            if (newvol != null)
            {
                switch (deviceType)
                {
                    case "tvset":
                        newvol.IncreaseVolume();
                        break;
                    default:
                        newvol.IncreaseVolume();
                        break;
                }

                tc.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        
        public ActionResult VolumeDecr(string deviceType)
        {
            IVolume newvol = vc.TVs.Find(deviceType);
            if (newvol != null)
            {
                switch (deviceType)
                {
                    case "tvset":
                        newvol.DecreaseVolume();
                        break;
                    default:
                        newvol.DecreaseVolume();
                        break;
                }

                tc.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //public ActionResult OniOffi(int id)
        //{
        //    IDictionary<int, AbstractDevice> SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
        //    SmartHome[id].OnOff();

        //    return RedirectToAction("Index");
        //}

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

    }
}