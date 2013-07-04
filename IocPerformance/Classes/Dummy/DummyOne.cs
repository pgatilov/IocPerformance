﻿using System.ComponentModel.Composition;

namespace IocPerformance.Classes.Dummy
{
    public interface IDummyOne
    {
    }

    [Export(typeof(IDummyOne)), PartCreationPolicy(CreationPolicy.NonShared)]
    public class DummyOne : IDummyOne
    {
    }
}
