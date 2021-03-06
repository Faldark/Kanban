﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kanban.Api.Common.Classes
{
    public interface IAutoMapConverter<TSourceObj, TDestinationObj>
        where TSourceObj : class
        where TDestinationObj : class
    {
        TDestinationObj ConvertObject(TSourceObj srcObj);
        List<TDestinationObj> ConvertObjectCollection(IEnumerable<TSourceObj> srcObj);
    }
}
