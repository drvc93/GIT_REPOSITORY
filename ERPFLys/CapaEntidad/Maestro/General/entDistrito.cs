﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entDistrito : entBase
    {
        private String c_Pais, c_DepartamentoCodigo, c_ProvinciaCodigo, c_DistritoCodigo, c_Descripcion, c_Estado = "A", c_UltimoUsuario, c_CodigoDistFedd, c_Ubigeo;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_DepartamentoNombre, c_ProvinciaNombre, c_UserNombreForm;

        public String Pais
        {
            get { return c_Pais; }
            set { c_Pais = value; }
        }

        public String DepartamentoCodigo
        {
            get { return c_DepartamentoCodigo; }
            set { c_DepartamentoCodigo = value; }
        }

        public String ProvinciaCodigo
        {
            get { return c_ProvinciaCodigo; }
            set { c_ProvinciaCodigo = value; }
        }

        public String DistritoCodigo
        {
            get { return c_DistritoCodigo; }
            set { c_DistritoCodigo = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
        }

        public String UltimoUsuario
        {
            get { return c_UltimoUsuario; }
            set { c_UltimoUsuario = value; }
        }

        public DateTime UltimaFechaModificacion
        {
            get { return d_UltimaFechaModificacion; }
            set { d_UltimaFechaModificacion = value; }
        }

        public String CodigoDistFedd
        {
            get { return c_CodigoDistFedd; }
            set { c_CodigoDistFedd = value; }
        }

        public String Ubigeo
        {
            get { return c_Ubigeo; }
            set { c_Ubigeo = value; }
        }

        public String DepartamentoNombre
        {
            get { return c_DepartamentoNombre; }
            set { c_DepartamentoNombre = value; }
        }

        public String ProvinciaNombre
        {
            get { return c_ProvinciaNombre; }
            set { c_ProvinciaNombre = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}