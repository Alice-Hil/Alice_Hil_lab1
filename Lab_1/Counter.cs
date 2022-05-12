using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
	public class Counter
	{ 
		private int startValue;
		private int finishValue;
		private int currentNum;
		public int StartValue { get { return startValue; } set { startValue = value; } }
		public int FinishValue { get { return finishValue; } set { finishValue = value; } }
		public int CurrentNum { get { return currentNum; } set { currentNum = value; } }
		

		public Counter(int startPoint = 1, int finishPoint = 9)
		{
			startValue = startPoint;
			finishValue = finishPoint;
			currentNum = startValue;
		}

		public void PrintCurrent()
        {
			Console.WriteLine("Current num is " + currentNum);
        }

		public void PlusOne()
        {
			currentNum++;
			if(currentNum > finishValue)
            {
				currentNum--;
				Console.WriteLine("Impossible to change - reached max value");
            }
        }

		public void MinusOne()
		{
			currentNum--;
			if (currentNum < startValue)
			{
				currentNum++;
				Console.WriteLine("Impossible to change - reached min value");
			}
		}
	}
}
