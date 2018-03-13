import { Component, Injector } from '@angular/core';
import { EditEnfermedadeGenerated } from './edit-enfermedade-generated.component';

@Component({
  selector: 'edit-enfermedade',
  templateUrl: './edit-enfermedade.component.html'
})
export class EditEnfermedadeComponent extends EditEnfermedadeGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
