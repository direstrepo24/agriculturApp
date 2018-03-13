import { Component, Injector } from '@angular/core';
import { AddNotificacioneGenerated } from './add-notificacione-generated.component';

@Component({
  selector: 'add-notificacione',
  templateUrl: './add-notificacione.component.html'
})
export class AddNotificacioneComponent extends AddNotificacioneGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
