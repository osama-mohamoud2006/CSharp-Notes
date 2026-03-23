using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     class Core
    {
        public enum enOperation: byte
        {
            Add =1 , Sub =2 , Div= 3 , Multi = 4 , Mod =5 
        }

        public void SimpleCalc( Decimal N1 , Decimal N2, enOperation Operation , out Decimal Res )
        {
            Res = 0m;
            switch(Operation)
            {
                case enOperation.Add:
                    Res = N1 + N2;
                    break;

                case enOperation.Sub:
                    Res = N1 - N2;
                    break;

                case enOperation.Multi:
                    Res = N1 * N2;
                    break;

                case enOperation.Div:
                    Res = (N2==0)?N1/1 : N1/N2;
                    break;

                case enOperation.Mod:
                    Res = N1 % N2;
                    break; 

            }
        }

    }



    }
