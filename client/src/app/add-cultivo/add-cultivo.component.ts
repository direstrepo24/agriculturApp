import { Component, Injector } from '@angular/core';
import { AddCultivoGenerated } from './add-cultivo-generated.component';

@Component({
  selector: 'add-cultivo',
  templateUrl: './add-cultivo.component.html'
})
export class AddCultivoComponent extends AddCultivoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
