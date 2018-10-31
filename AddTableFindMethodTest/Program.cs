﻿using Dynamics.AX.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TRUDUtilsD365.AddTableFindMethod;
using TRUDUtilsD365.CreateExtensionClass;
using TRUDUtilsD365.EnumCreator;

namespace AddTableFindMethodTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //TestAddTableFindMethod();
            //TestCreateExtensionClass();
            TestEnumCreator();
        }

        private static void TestCreateExtensionClass()
        {
            CreateExtensionClassDialog dialog = new CreateExtensionClassDialog();

            CreateExtensionClassParms parms = new CreateExtensionClassParms();

            parms.ElementName = "CustTable";
            parms.ElementType = UtilElementType.Form;
            parms.Prefix = "MY";
            parms.ClassType = ExtensionClassType.EventHandler;

            dialog.SetParameters(parms);

            Application.Run(dialog);
        }

        private static void TestEnumCreator()
        {
            EnumCreatorDialog dialog = new EnumCreatorDialog();
            EnumCreatorParms parms = new EnumCreatorParms();

            dialog.SetParameters(parms);

            Application.Run(dialog);
        }


        private static void TestAddTableFindMethod()
        {
            AddTableFindMethodDialog dialog = new AddTableFindMethodDialog();

            AddTableFindMethodParms parms = new AddTableFindMethodParms();
            //parms.MethodName = "find3";
            parms.IsTestMode = true;
            parms.TableName = "MyTable";
            parms.Fields = new List<AxTableFieldParm> {
                new AxTableFieldParm { FieldName = "Field1",    FieldType = "Type1",    IsMandatory = true },
                new AxTableFieldParm { FieldName = "Field2Big", FieldType = "Type2Big", IsMandatory = true },
                new AxTableFieldParm { FieldName = "F3",        FieldType = "T3",       IsMandatory = false }
            };

            dialog.SetParameters(parms);

            Application.Run(dialog);
        }
    }
}