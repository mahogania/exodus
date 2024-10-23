import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { AssociationTypeServiceBase } from "./base/associationType.service.base";

@Injectable()
export class AssociationTypeService extends AssociationTypeServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
