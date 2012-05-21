using System;

namespace Instartius.Imp.Port
{
	public class ParallelOperator
	{
		private int i = 0;
		private int j = 0; 
		private Int32 adress = 888;

		public Int32 Address { get {return adress;} }

		/// Makes all the data pins low so the LED's turned off
		private void ResetLEDs()
		{
			i = 0;
			j = 0;
			PortAccess.Output(Address, 0);
		}

		public void Activate(params bool[] bytes)
		{
			if(bytes.Length == 8)
			{
				int value = 0;

				if(bytes[0])
					value += (int) Math.Pow(2,0);
				else
					value += 0;
				
				if(bytes[1])
					value += (int) Math.Pow(2,1);
				else
					value += 0;

				if(bytes[2])
					value += (int) Math.Pow(2,2);
				else
					value += 0;
				
				if(bytes[3])
					value += (int) Math.Pow(2,3);
				else
					value += 0;
				
				if(bytes[4])
					value += (int) Math.Pow(2,4);
				else
					value += 0;
				
				if(bytes[5])
					value += (int) Math.Pow(2,5);
				else
					value += 0;
			
				if(bytes[6])
					value += (int) Math.Pow(2,6);
				else
					value += 0;
				
				if(bytes[7])
					value += (int)Math.Pow(2,7);
				else
					value += 0;

				PortAccess.Output(Address, value);
			}
		}

		public void ActivateByLoop(params bool[] bytes)
		{
			int value = 0;

			for(int i = 0 ; i < bytes.Length ; i++)
			{
				if(bytes[i])
					value += (int) Math.Pow(2, i);
				else
					value += 0;
			}

            PortAccess.Output(Address, value);
		}

		public void ActivateSignal(int signal)
		{
			PortAccess.Output(Address, signal);
		}

	}
}