using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebook.Api
{
    public abstract class FacebookServiceRequest
    {

        public abstract Type ElementType { get; }

        public abstract Uri RequestUri { get; }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}
