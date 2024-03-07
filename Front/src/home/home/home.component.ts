import { Component, Inject, OnInit } from "@angular/core";
import { TestClient } from "../../shared/services/api.service";

@Component({
  selector: 'home',
  templateUrl: 'home.component.html'
})
export class HomeComponent implements OnInit {
  motd: string = '[motd]';
  constructor(private client: TestClient) {}
  ngOnInit(): void {
    this.client.getMotd().subscribe(d => {
      this.motd = d;
    })
  }

}
