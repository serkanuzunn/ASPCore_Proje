﻿using BusinessLogicLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Proje.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {

            var values = serviceManager.TGetList();
            return View(values);
        }
    
    }
}