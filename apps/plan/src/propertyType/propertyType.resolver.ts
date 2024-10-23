import * as graphql from "@nestjs/graphql";
import * as nestAccessControl from "nest-access-control";
import * as gqlACGuard from "../auth/gqlAC.guard";
import { GqlDefaultAuthGuard } from "../auth/gqlDefaultAuth.guard";
import * as common from "@nestjs/common";
import { PropertyTypeResolverBase } from "./base/propertyType.resolver.base";
import { PropertyType } from "./base/PropertyType";
import { PropertyTypeService } from "./propertyType.service";

@common.UseGuards(GqlDefaultAuthGuard, gqlACGuard.GqlACGuard)
@graphql.Resolver(() => PropertyType)
export class PropertyTypeResolver extends PropertyTypeResolverBase {
  constructor(
    protected readonly service: PropertyTypeService,
    @nestAccessControl.InjectRolesBuilder()
    protected readonly rolesBuilder: nestAccessControl.RolesBuilder
  ) {
    super(service, rolesBuilder);
  }
}
