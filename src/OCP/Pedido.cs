﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Pedido
    {
        public virtual double DescontoPedido(double valorFinal)
        {
            return valorFinal;
        }
    }
}
