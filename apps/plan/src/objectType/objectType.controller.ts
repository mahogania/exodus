import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as nestAccessControl from "nest-access-control";
import { ObjectTypeService } from "./objectType.service";
import { ObjectTypeControllerBase } from "./base/objectType.controller.base";

@swagger.ApiTags("objectTypes")
@common.Controller("objectTypes")
export class ObjectTypeController extends ObjectTypeControllerBase {
  constructor(
    protected readonly service: ObjectTypeService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
