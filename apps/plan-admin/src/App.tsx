import React, { useEffect, useState, useRef } from "react";
import { Admin, AuthProvider, DataProvider, Resource } from "react-admin";
import Keycloak from "keycloak-js";
import {
  keycloakClient,
  keycloakAuthProvider,
} from "./auth-provider/ra-auth-keycloak";
import buildGraphQLProvider from "./data-provider/graphqlDataProvider";
import { theme } from "./theme/theme";
import Login from "./Login";
import "./App.scss";
import Dashboard from "./pages/Dashboard";
import { UserList } from "./user/UserList";
import { UserCreate } from "./user/UserCreate";
import { UserEdit } from "./user/UserEdit";
import { UserShow } from "./user/UserShow";
import { PropertyTypeList } from "./propertyType/PropertyTypeList";
import { PropertyTypeCreate } from "./propertyType/PropertyTypeCreate";
import { PropertyTypeEdit } from "./propertyType/PropertyTypeEdit";
import { PropertyTypeShow } from "./propertyType/PropertyTypeShow";
import { PropertyList } from "./property/PropertyList";
import { PropertyCreate } from "./property/PropertyCreate";
import { PropertyEdit } from "./property/PropertyEdit";
import { PropertyShow } from "./property/PropertyShow";
import { ObjectTypeList } from "./objectType/ObjectTypeList";
import { ObjectTypeCreate } from "./objectType/ObjectTypeCreate";
import { ObjectTypeEdit } from "./objectType/ObjectTypeEdit";
import { ObjectTypeShow } from "./objectType/ObjectTypeShow";
import { ObjectList } from "./object/ObjectList";
import { ObjectCreate } from "./object/ObjectCreate";
import { ObjectEdit } from "./object/ObjectEdit";
import { ObjectShow } from "./object/ObjectShow";
import { EventTypeList } from "./eventType/EventTypeList";
import { EventTypeCreate } from "./eventType/EventTypeCreate";
import { EventTypeEdit } from "./eventType/EventTypeEdit";
import { EventTypeShow } from "./eventType/EventTypeShow";
import { EventList } from "./event/EventList";
import { EventCreate } from "./event/EventCreate";
import { EventEdit } from "./event/EventEdit";
import { EventShow } from "./event/EventShow";
import { AssociationTypeList } from "./associationType/AssociationTypeList";
import { AssociationTypeCreate } from "./associationType/AssociationTypeCreate";
import { AssociationTypeEdit } from "./associationType/AssociationTypeEdit";
import { AssociationTypeShow } from "./associationType/AssociationTypeShow";
import { WorkflowList } from "./workflow/WorkflowList";
import { WorkflowCreate } from "./workflow/WorkflowCreate";
import { WorkflowEdit } from "./workflow/WorkflowEdit";
import { WorkflowShow } from "./workflow/WorkflowShow";
import { TaskList } from "./task/TaskList";
import { TaskCreate } from "./task/TaskCreate";
import { TaskEdit } from "./task/TaskEdit";
import { TaskShow } from "./task/TaskShow";
import { ActionList } from "./action/ActionList";
import { ActionCreate } from "./action/ActionCreate";
import { ActionEdit } from "./action/ActionEdit";
import { ActionShow } from "./action/ActionShow";
import { AssociationList } from "./association/AssociationList";
import { AssociationCreate } from "./association/AssociationCreate";
import { AssociationEdit } from "./association/AssociationEdit";
import { AssociationShow } from "./association/AssociationShow";
import { StepList } from "./step/StepList";
import { StepCreate } from "./step/StepCreate";
import { StepEdit } from "./step/StepEdit";
import { StepShow } from "./step/StepShow";

const App = (): React.ReactElement => {
  const [dataProvider, setDataProvider] = useState<DataProvider | null>(null);
  const [keycloak, setKeycloak] = useState<Keycloak | null>();
  const authProvider = useRef<AuthProvider | null>();

  useEffect(() => {
    buildGraphQLProvider
      .then((provider: any) => {
        setDataProvider(() => provider);
      })
      .catch((error: any) => {
        console.log(error);
      });
  }, []);

  useEffect(() => {
    const initKeyCloakClient = async () => {
      await keycloakClient.init({
        onLoad: "login-required",
      });
      authProvider.current = keycloakAuthProvider(keycloakClient, {});
      setKeycloak(keycloakClient);
    };
    if (!keycloak) {
      initKeyCloakClient();
    }
  }, [keycloak]);

  if (!dataProvider || !authProvider.current) {
    return <div>Loading</div>;
  }

  return (
    <div className="App">
      <Admin
        title={"Plan"}
        dataProvider={dataProvider}
        authProvider={authProvider.current}
        theme={theme}
        dashboard={Dashboard}
        loginPage={Login}
      >
        <Resource
          name="User"
          list={UserList}
          edit={UserEdit}
          create={UserCreate}
          show={UserShow}
        />
        <Resource
          name="PropertyType"
          list={PropertyTypeList}
          edit={PropertyTypeEdit}
          create={PropertyTypeCreate}
          show={PropertyTypeShow}
        />
        <Resource
          name="Property"
          list={PropertyList}
          edit={PropertyEdit}
          create={PropertyCreate}
          show={PropertyShow}
        />
        <Resource
          name="ObjectType"
          list={ObjectTypeList}
          edit={ObjectTypeEdit}
          create={ObjectTypeCreate}
          show={ObjectTypeShow}
        />
        <Resource
          name="Object"
          list={ObjectList}
          edit={ObjectEdit}
          create={ObjectCreate}
          show={ObjectShow}
        />
        <Resource
          name="EventType"
          list={EventTypeList}
          edit={EventTypeEdit}
          create={EventTypeCreate}
          show={EventTypeShow}
        />
        <Resource
          name="Event"
          list={EventList}
          edit={EventEdit}
          create={EventCreate}
          show={EventShow}
        />
        <Resource
          name="AssociationType"
          list={AssociationTypeList}
          edit={AssociationTypeEdit}
          create={AssociationTypeCreate}
          show={AssociationTypeShow}
        />
        <Resource
          name="Workflow"
          list={WorkflowList}
          edit={WorkflowEdit}
          create={WorkflowCreate}
          show={WorkflowShow}
        />
        <Resource
          name="Task"
          list={TaskList}
          edit={TaskEdit}
          create={TaskCreate}
          show={TaskShow}
        />
        <Resource
          name="Action"
          list={ActionList}
          edit={ActionEdit}
          create={ActionCreate}
          show={ActionShow}
        />
        <Resource
          name="Association"
          list={AssociationList}
          edit={AssociationEdit}
          create={AssociationCreate}
          show={AssociationShow}
        />
        <Resource
          name="Step"
          list={StepList}
          edit={StepEdit}
          create={StepCreate}
          show={StepShow}
        />
      </Admin>
    </div>
  );
};

export default App;
