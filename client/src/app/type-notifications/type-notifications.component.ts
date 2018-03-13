import { Component, Injector } from '@angular/core';
import { TypeNotificationsGenerated } from './type-notifications-generated.component';

@Component({
  selector: 'type-notifications',
  templateUrl: './type-notifications.component.html'
})
export class TypeNotificationsComponent extends TypeNotificationsGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
