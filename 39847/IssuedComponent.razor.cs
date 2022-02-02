using Microsoft.AspNetCore.Components;

namespace _39847;

public partial class IssuedComponent<TItem>
{
	[Parameter]
	public RenderFragment ChildContent { get; set; }

	[Parameter]
	public EventCallback<TItem> EventCallback { get; set; }
}
