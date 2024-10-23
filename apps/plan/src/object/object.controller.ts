import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as nestAccessControl from "nest-access-control";
import { ObjectService } from "./object.service";
import { ObjectControllerBase } from "./base/object.controller.base";

@swagger.ApiTags("objects")
@common.Controller("objects")
export class ObjectController extends ObjectControllerBase {
  constructor(
    protected readonly service: ObjectService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
