import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as nestAccessControl from "nest-access-control";
import { PropertyTypeService } from "./propertyType.service";
import { PropertyTypeControllerBase } from "./base/propertyType.controller.base";

@swagger.ApiTags("propertyTypes")
@common.Controller("propertyTypes")
export class PropertyTypeController extends PropertyTypeControllerBase {
  constructor(
    protected readonly service: PropertyTypeService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
