﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal.Componente
{
    internal enum Categoria
    {
        FIN_ARCHIVO, FIN_LINEA, CAMPO, TABLA, LITERAL, WHERE, FROM, SELECT, ORDER_BY, AND, OR, ASC, DESC, DECIMAL, ENTERO, IGUAL, DIFERENTE_QUE, MAYOR_QUE, MENOR_QUE, MENOR_O_IGUAL_QUE, MAYOR_O_IGUAL_QUE
    }
}
