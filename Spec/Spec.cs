using System;
using System.Collections.Generic;
using Machine.Specifications;

namespace Training.Spec
{
    public class test_concern 
    {
        static int sut;
        const int initial_value = 5;

        Establish context = () =>
            sut = initial_value;

        private Because of = () =>
            sut = sut + 1;

        It sut_should_be_propery_incremented = () =>
            sut.ShouldEqual(initial_value+1);
    }
    
}

