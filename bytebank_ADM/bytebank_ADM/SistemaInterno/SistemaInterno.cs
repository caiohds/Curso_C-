﻿using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario,string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            Console.WriteLine("Senha Incorreta!");
            return false;
        }
        
    }
}
