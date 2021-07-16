using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "58487488021";
            string cpf2 = "58487488020";
            string cpf3 = "58487488021";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);

            string cnpj1 = "60134472000169";
            string cnpj2 = "60134472000160";
            string cnpj3 = "60134472000169";

            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);
            ValidarCNPJ(cnpj3);

            string titutoEleitor1 = "446411750124";
            string titutoEleitor2 = "000000000000";
            string titutoEleitor3 = "446411750124";

            ValidarTITULOELEITOR(titutoEleitor1);
            ValidarTITULOELEITOR(titutoEleitor2);
            ValidarTITULOELEITOR(titutoEleitor3);
        }

        private static void ValidarTITULOELEITOR(string titutoEleitor)
        {
            if (new TituloEleitoralValidator().IsValid(titutoEleitor))
            {
                Debug.WriteLine("TÍTULO DE ELEITOR válido: " + titutoEleitor);
            }
            else
            {
                Debug.WriteLine("TÍTULO DE ELEITOR inválido: " + titutoEleitor);
            }
        }

        private static void ValidarCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Debug.WriteLine("CNPJ válido: " + cnpj);
            }
            else
            {
                Debug.WriteLine("CNPJ inválido: " + cnpj);
            }
        }

        private static void ValidarCPF(string cpf)
        {
            if (new CPFValidator().IsValid(cpf))
            {
                Debug.WriteLine("CPF válido: " + cpf);
            }
            else
            {
                Debug.WriteLine("CPF inválido: " + cpf);
            }
        }
    }
}
