using System;
using System.Collections.Generic;

namespace BD.Models;

public partial class Beer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? BrandId { get; set; }

    public virtual Beer? Brand { get; set; }

    //public virtual ICollection<Beer> InverseBrand { get; set; } = new List<Beer>();
}
