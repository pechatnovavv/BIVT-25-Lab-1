namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            answer = a > 0 && b > 0 || a < 0 && b < 0;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            answer = (int)d != d;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = b != 0 ? a % b == 0: false;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if ((d < 0 ? -d : d) > (f < 0 ? -f : f) && (d < 0 ? -d : d) > (g < 0 ? -g : g))
            {
                answer = d;
            }
            else if ((f < 0 ? -f : f) > (d < 0 ? -d : d) && (f < 0 ? -f : f) > (g < 0 ? -g : g))
            {
                answer = f;
            }
            else
            {
                answer = g;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 0.0;
            }
            else if (-1 < x && x <= 0)
            {
                answer = x + 1;
            }
            else
            {
                answer = 1;
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            answer = (circleS/3.141592653589793238) <= squareS / 4;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if ((d > 0 ? d : -d) < (f > 0 ? f : -f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int pa = a / 2;
            int pb = b / 2;
            int pc = c / 2;
            int sum = pa + pb + pc;
            bool c1 = (sum % 3) == 0 && (sum / 3) >= 1 && (sum / 3) <= c && (sum / 3) <= a && (sum / 3) <= b;
            bool c2 = (sum + 1) % 3 == 0 && (sum + 1) / 3 >= 1 && ((sum+1) / 3) <= c && (sum+1) / 3 <= a && (sum+1) / 3 <= b;
            answer = c1 || c2;
            // end

            return answer;
        }
    }
}