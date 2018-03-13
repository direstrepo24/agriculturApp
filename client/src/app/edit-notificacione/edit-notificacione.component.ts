import { Component, Injector } from '@angular/core';
import { EditNotificacioneGenerated } from './edit-notificacione-generated.component';

@Component({
  selector: 'edit-notificacione',
  templateUrl: './edit-notificacione.component.html'
})
export class EditNotificacioneComponent extends EditNotificacioneGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
