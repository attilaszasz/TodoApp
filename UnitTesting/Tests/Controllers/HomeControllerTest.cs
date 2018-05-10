﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Website;
using Website.Controllers;

namespace Tests.Controllers
{
    [TestClass]
    public class TodosControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            TodosController controller = new TodosController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
