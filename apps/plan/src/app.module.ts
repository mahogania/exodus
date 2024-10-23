import { Module } from "@nestjs/common";
import { UserModule } from "./user/user.module";
import { PropertyTypeModule } from "./propertyType/propertyType.module";
import { PropertyModule } from "./property/property.module";
import { ObjectTypeModule } from "./objectType/objectType.module";
import { ObjectModule } from "./object/object.module";
import { EventTypeModule } from "./eventType/eventType.module";
import { EventModule } from "./event/event.module";
import { AssociationTypeModule } from "./associationType/associationType.module";
import { WorkflowModule } from "./workflow/workflow.module";
import { TaskModule } from "./task/task.module";
import { ActionModule } from "./action/action.module";
import { AssociationModule } from "./association/association.module";
import { StepModule } from "./step/step.module";
import { HealthModule } from "./health/health.module";
import { PrismaModule } from "./prisma/prisma.module";
import { SecretsManagerModule } from "./providers/secrets/secretsManager.module";
import { ServeStaticModule } from "@nestjs/serve-static";
import { ServeStaticOptionsService } from "./serveStaticOptions.service";
import { ConfigModule, ConfigService } from "@nestjs/config";
import { GraphQLModule } from "@nestjs/graphql";
import { ApolloDriver, ApolloDriverConfig } from "@nestjs/apollo";

import { ACLModule } from "./auth/acl.module";
import { AuthModule } from "./auth/auth.module";

@Module({
  controllers: [],
  imports: [
    ACLModule,
    AuthModule,
    UserModule,
    PropertyTypeModule,
    PropertyModule,
    ObjectTypeModule,
    ObjectModule,
    EventTypeModule,
    EventModule,
    AssociationTypeModule,
    WorkflowModule,
    TaskModule,
    ActionModule,
    AssociationModule,
    StepModule,
    HealthModule,
    PrismaModule,
    SecretsManagerModule,
    ConfigModule.forRoot({ isGlobal: true }),
    ServeStaticModule.forRootAsync({
      useClass: ServeStaticOptionsService,
    }),
    GraphQLModule.forRootAsync<ApolloDriverConfig>({
      driver: ApolloDriver,
      useFactory: (configService: ConfigService) => {
        const playground = configService.get("GRAPHQL_PLAYGROUND");
        const introspection = configService.get("GRAPHQL_INTROSPECTION");
        return {
          autoSchemaFile: "schema.graphql",
          sortSchema: true,
          playground,
          introspection: playground || introspection,
        };
      },
      inject: [ConfigService],
      imports: [ConfigModule],
    }),
  ],
  providers: [],
})
export class AppModule {}
