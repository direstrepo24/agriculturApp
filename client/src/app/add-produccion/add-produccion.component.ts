import { Component, Injector } from '@angular/core';
import { AddProduccionGenerated } from './add-produccion-generated.component';

@Component({
  selector: 'add-produccion',
  templateUrl: './add-produccion.component.html'
})
export class AddProduccionComponent extends AddProduccionGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
