﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class QuestCompletionItem
    {
        public Item details { get; set; }
        public int Quantity { get; set; }

        public QuestCompletionItem(Item details , int quantity)
        {
            this.details = details;
            this.Quantity = quantity;
        }
    }
}
