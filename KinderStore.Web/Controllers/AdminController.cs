﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KinderStore.Domain.Abstract;

namespace KinderStore.Web.Controllers
{
    public class AdminController : Controller
    {
	    private IProductRepository _repository;

	    public AdminController(IProductRepository repo)
	    {
		    _repository = repo;
	    }

	    public ViewResult Index()
	    {
		    return View(_repository.Products);
	    }
    }
}