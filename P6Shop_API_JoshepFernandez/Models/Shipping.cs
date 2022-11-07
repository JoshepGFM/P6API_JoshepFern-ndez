﻿using System;
using System.Collections.Generic;

namespace P6Shop_API_JoshepFernandez.Models
{
    public partial class Shipping
    {
        public int Idshipping { get; set; }
        public int ShippingZipCode { get; set; }
        public string ShippingCity { get; set; } = null!;
        public string ShippingStreet { get; set; } = null!;
        public string ShippingAddress { get; set; } = null!;
        public bool? ShippingDelivered { get; set; }
        public int Idinvoice { get; set; }
        public int IdshippingChannel { get; set; }

        public virtual Invoice IdinvoiceNavigation { get; set; } = null!;
        public virtual ShippingChannel IdshippingChannelNavigation { get; set; } = null!;
    }
}
