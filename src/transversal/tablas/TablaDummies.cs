﻿using Compilador.src.transversal.componentes;
using System;
using System.Collections.Generic;

namespace Compilador.src.transversal.tablas
{
    public class TablaDummies
    {
        private static Dictionary<String, List<ComponenteLexico>> TABLA = new Dictionary<string, List<ComponenteLexico>>();

        public static void reiniciar()
        {
            TABLA.Clear();
        }

        public static List<ComponenteLexico> obtenerComponentes(String lexema)
        {
            if (!TABLA.ContainsKey(lexema))
            {
                TABLA.Add(lexema, new List<ComponenteLexico>());
            }

            return TABLA[lexema];
        }

        public static void agregar(ComponenteLexico componenteLexico)
        {
            if (componenteLexico != null && Tipo.DUMMY.Equals(componenteLexico.obtenerTipo()))
            {
                obtenerComponentes(componenteLexico.obtenerLexema()).Add(componenteLexico);

            }
        }

        public static List<ComponenteLexico> ObtenerComponentes()
        {
            var componentes = new List<ComponenteLexico>();

            foreach (List<ComponenteLexico> lista in TABLA.Values)
            {
                componentes.AddRange(lista);
            }

            return componentes;
        }
    }
}