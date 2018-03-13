import { Component, Injector } from '@angular/core';
import { EditCultivoGenerated } from './edit-cultivo-generated.component';

@Component({
  selector: 'edit-cultivo',
  templateUrl: './edit-cultivo.component.html'
})
export class EditCultivoComponent extends EditCultivoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
