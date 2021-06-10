using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Ball
    {
        private int _size = 1;
        private int _throw = 0;

        public Color Color{get; set;}

        public void Pop()
        {
            _size = 0;
        }

        public void Throw()
        {
            if(_size > 0)
            {
                _throw++;
            }
        }

        public int Points()
        {
            return _throw;
        }



    }


} 
