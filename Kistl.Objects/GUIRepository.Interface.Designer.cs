// <autogenerated/>

using System.Linq;

using Kistl.API;

namespace Kistl.App.GUI
{

	public class GUIRepository
	{
		public GUIRepository(IKistlContext ctx)
		{
			this.Context = ctx;
		}
		
		public IKistlContext Context { get; private set; }
		
		/// <summary>List of all Visual</summary>
		/// 
		public IQueryable<Visual> Visuals
		{ 
			get
			{
				return Context.GetQuery<Visual>();
			}
		}
		
		/// <summary>List of all ViewModelDescriptor</summary>
		/// 
		public IQueryable<ViewModelDescriptor> ViewModelDescriptors
		{ 
			get
			{
				return Context.GetQuery<ViewModelDescriptor>();
			}
		}
		
		/// <summary>List of all ViewDescriptor</summary>
		/// 
		public IQueryable<ViewDescriptor> ViewDescriptors
		{ 
			get
			{
				return Context.GetQuery<ViewDescriptor>();
			}
		}
		
		/// <summary>List of all Template</summary>
		/// 
		public IQueryable<Template> Templates
		{ 
			get
			{
				return Context.GetQuery<Template>();
			}
		}
		
		/// <summary>List of all Icon</summary>
		/// 
		public IQueryable<Icon> Icons
		{ 
			get
			{
				return Context.GetQuery<Icon>();
			}
		}
		
		/// <summary>List of all ControlKind</summary>
		/// The ControlKind specifies the toolkit-independent kind or type of control that should display a given Presentable.
		public IQueryable<ControlKind> ControlKinds
		{ 
			get
			{
				return Context.GetQuery<ControlKind>();
			}
		}
		
	
	}
	
}