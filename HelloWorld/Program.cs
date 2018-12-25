using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabadorGitMHIS
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion1, opcion2;
            string comentario, rutaFront, rutaBack, bitbucketAccount, gitAddCommit, gitPush, gitPushFinal, strCmdText, front, back;
            bitbucketAccount = "belenescudero";
            rutaBack = "C:\\Git\\mhis_backend";
            rutaFront = "C:\\Git\\mhis_frontend";
            front = "frontend";
            back = "backend";

            Console.WriteLine("¿En que proyecto de MHIS vas a trabajar?:");
            Console.WriteLine("1) Backend. 2) Frontend");
            opcion1=int.Parse(Console.ReadLine());
            if (opcion1 == 1)
            {
                Console.WriteLine("¿Que hacersh?");
                Console.WriteLine("1) Guardar. 2) Obtener");
                opcion2 = int.Parse(Console.ReadLine());

                if (opcion2 == 1)
                {
                    Console.WriteLine("Ingresar comentario para grabar:");
                    comentario = Console.ReadLine();
                    gitAddCommit = "&& git add --all && git commit -m ";
                    gitPush = " && git push origin branch_" + back + "_" + bitbucketAccount ;
                    gitPushFinal = gitAddCommit + "\"" + comentario + "\"" + gitPush;

                    strCmdText = "/C cd " + rutaBack + gitPushFinal;
                    Console.WriteLine(strCmdText);
                    Process.Start("CMD.exe", strCmdText);
                }

                if (opcion2 == 2)
                {
                    strCmdText = "/C cd " + rutaBack + " && git pull origin master";
                    Console.WriteLine(strCmdText);
                    Process.Start("CMD.exe", strCmdText);
                }

                if (opcion2 != 1 || opcion2 != 2) 
                {
                    Console.WriteLine("La opción ingresada no es válida");
                }

            }

            if (opcion1 == 2)
            {
                Console.WriteLine("¿Que hacersh?");
                Console.WriteLine("1) Guardar. 2) Obtener");
                opcion2 = int.Parse(Console.ReadLine());

                if (opcion2 == 1)
                {
                    Console.WriteLine("Ingresar comentario para grabar:");
                    comentario = Console.ReadLine();
                    gitAddCommit = "&& git add --all && git commit -m " ;
                    gitPush = " && git push origin branch_" + front + "_" + bitbucketAccount ;
                    gitPushFinal = gitAddCommit + "\"" + comentario + "\"" + gitPush;
                    
                    strCmdText = "/C cd " + rutaFront + gitPushFinal;
                    Process.Start("CMD.exe", strCmdText);
                }

                if (opcion2 == 2)
                {
                    strCmdText = "/C cd " + rutaFront + " && git pull origin master";                 
                    Process.Start("CMD.exe", strCmdText);
                }

                if (opcion2 != 1 || opcion2 != 2)
                {
                    Console.WriteLine("La opción ingresada no es válida");
                }

            }

                if (opcion1 != 1 || opcion1 != 2) 
                {
                    Console.WriteLine("La opción ingresada no es válida");
                }

            Console.ReadKey();
        }
    }
}
