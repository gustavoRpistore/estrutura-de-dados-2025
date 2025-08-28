using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace QUEUES
{
    public class CallCenter
    {
        private int _counter = 0;

        public Queue<IncomingCall> Calls { get; private set; } = [];

        //zero nao e nulo//
        /*atenção: metodos construtores possuim o mesmo nome de classe (regra)
        sao invocados quando controi-se uma nova instancia de objetivo deste tipo
         */


        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();
        }
        public void call(int ClientId)
        {
            IncomingCall call = new IncomingCall();
            call.Id = ++_counter;
            call.ClientId = ClientId;
            call.Calltime = DateTime.Now;

            Calls.Enqueue(call);
        }

        public IncomingCall Answer(string consultant)
        {
            if (Calls.Count > 0)
            {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;

                return call;

            }

            return null!;
        }
        public void End(IncomingCall)
        {
            Call.Endtime = DateTime.Now;

        }
        public bool ArewaitingCalls()
        {
            return Calls.count > 0;
        }
    }
    
}