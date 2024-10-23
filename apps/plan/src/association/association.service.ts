import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { AssociationServiceBase } from "./base/association.service.base";

@Injectable()
export class AssociationService extends AssociationServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
