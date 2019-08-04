using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyEx.Models;

namespace VidlyEx.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movies Movie{ get; set; }
        public List<Customer> Customers { get; set; }
    }
    
}