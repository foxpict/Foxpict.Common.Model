using Hyperion.Pf.Entity;

namespace Foxpict.Common.Model {
  public interface ILabel : IEntity<long> {
    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    string Name { get; set; }

    string MetaType { get; set; }

    string Comment { get; set; }
  }
}
