﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Booky.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            var books = new List<Book>
            {
                new Book()
                {
                    Title = "Harry Potter and The Philosopher's Stone",
                    Author = "J. K. Rowling",
                    IsbnCode = "9788700631625",
                    PublishedDate = new DateTime(1997, 6, 26),
                    Summary = @"Harry Potter, an eleven-year-old orphan, discovers that 
                                he is a wizard and is invited to study at Hogwarts. 
                                Even as he escapes a dreary life and enters a world of magic, 
                                he finds trouble awaiting him."
                }
            };

            return Ok(books);
        }
    }
}