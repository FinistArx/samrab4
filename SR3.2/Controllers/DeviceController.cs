using SamRab3_2.Models.Contex;
using SR3._2.Models.Device;
using SR3._2.Models.Interfaces;
using System.Collections.Generic;
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

            foreach (AbstractDevice item in bb.Devices.ToList())
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

        public ActionResult TempIncrease(int id)
        {
            Temperature newtemp = bb.Temperatures.Find(id);
            if (newtemp != null)
            {
                switch (id)
                {
                    case 1:
                        newtemp.IncreaseTemp();
                        break;
                    case 2:
                        newtemp.IncreaseTemp();
                        break;
                    default:
                        newtemp.IncreaseTemp();
                        break;
                }
                bb.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult TempDecrease(int id)
        {
            Temperature newtemp = bb.Temperatures.Find(id);
            if (newtemp != null)
            {
                switch (id)
                {
                    case 1:
                        newtemp.DecreaseTemp();
                        break;
                    case 2:
                        newtemp.DecreaseTemp();
                        break;
                    default:
                        newtemp.DecreaseTemp();
                        break;
                }
                bb.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult VolumeIncr(int id)
        {
            if (id == 4)
            {
                IVolume newvol = bb.MCs.Find(id);
                newvol.IncreaseVolume();
            }
            if (id == 5)
            {
                IVolume newvol2 = bb.TVs.Find(id);
                newvol2.IncreaseVolume();
            }
            bb.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult VolumeDecr(int id)
        {
            if (id == 4)
            {
                IVolume newvol = bb.MCs.Find(id);
                newvol.DecreaseVolume();
            }
            if (id == 5)
            {
                IVolume newvol2 = bb.TVs.Find(id);
                newvol2.DecreaseVolume();
            }
            bb.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult NextChenell(int id)
        {
            if (id == 4)
            {
                IChangeChennel newvol = bb.MCs.Find(id);
                newvol.NextChennel();
            }
            if (id == 5)
            {
                IChangeChennel newvol2 = bb.TVs.Find(id);
                newvol2.NextChennel();
            }
            bb.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PrevChenell(int id)
        {
            if (id == 4)
            {
                IChangeChennel newvol = bb.MCs.Find(id);
                newvol.PreviusChennel();
            }
            if (id == 5)
            {
                IChangeChennel newvol2 = bb.TVs.Find(id);
                newvol2.PreviusChennel();
            }
            bb.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
