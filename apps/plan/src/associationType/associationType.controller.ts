import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as nestAccessControl from "nest-access-control";
import { AssociationTypeService } from "./associationType.service";
import { AssociationTypeControllerBase } from "./base/associationType.controller.base";

@swagger.ApiTags("associationTypes")
@common.Controller("associationTypes")
export class AssociationTypeController extends AssociationTypeControllerBase {
  constructor(
    protected readonly service: AssociationTypeService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
