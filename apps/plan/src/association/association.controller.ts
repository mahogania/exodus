import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as nestAccessControl from "nest-access-control";
import { AssociationService } from "./association.service";
import { AssociationControllerBase } from "./base/association.controller.base";

@swagger.ApiTags("associations")
@common.Controller("associations")
export class AssociationController extends AssociationControllerBase {
  constructor(
    protected readonly service: AssociationService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
