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
		
		/// <summary>List of all PresenterInfo</summary>
		/// 
		public IQueryable<PresenterInfo> PresenterInfos
		{ 
			get
			{
				return Context.GetQuery<PresenterInfo>();
			}
		}
		
		/// <summary>List of all PresentableModelDescriptor</summary>
		/// 
		public IQueryable<PresentableModelDescriptor> PresentableModelDescriptors
		{ 
			get
			{
				return Context.GetQuery<PresentableModelDescriptor>();
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
		
		/// <summary>List of all ControlInfo</summary>
		/// 
		public IQueryable<ControlInfo> ControlInfos
		{ 
			get
			{
				return Context.GetQuery<ControlInfo>();
			}
		}
		
	
	}
	
}