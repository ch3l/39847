using Microsoft.AspNetCore.Components;

namespace _39847;

[CascadingTypeParameter(nameof(TItem))]
public partial class CascadingTypeparamComponent<TItem>
{
	[Parameter]
	public RenderFragment ChildContent { get; set; }
}
