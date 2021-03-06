using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using TRMDesktopUI.EventModels;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;
        private SalesViewModel _salesVM;
        private SimpleContainer _container;

        public ShellViewModel(IEventAggregator events, SalesViewModel salesVM, SimpleContainer container)
        {
            _events = events;
            _salesVM = salesVM;
            _container = container;

            _events.Subscribe(this);

            ActivateItem(IoC.Get<LoginViewModel>());
        }

        /// <summary>
        /// Triggred when someone logs in successfully in API.
        /// </summary>                
        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
        }
    }
}
