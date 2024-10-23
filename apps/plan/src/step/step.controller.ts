import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as nestAccessControl from "nest-access-control";
import { StepService } from "./step.service";
import { StepControllerBase } from "./base/step.controller.base";

@swagger.ApiTags("steps")
@common.Controller("steps")
export class StepController extends StepControllerBase {
  constructor(
    protected readonly service: StepService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
