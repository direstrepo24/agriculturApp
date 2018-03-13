import { Component, Injector } from '@angular/core';
import { EditTypeNotificationGenerated } from './edit-type-notification-generated.component';

@Component({
  selector: 'edit-type-notification',
  templateUrl: './edit-type-notification.component.html'
})
export class EditTypeNotificationComponent extends EditTypeNotificationGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
