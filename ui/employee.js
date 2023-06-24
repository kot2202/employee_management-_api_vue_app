const employee={template:`
<h1>Manage Employees</h1>

<button type="button"
class="btn btn-primary m-2 fload-end"
data-bs-toggle="modal"
data-bs-target="#exampleModal"
@click="addClick()">
 Add Employee
</button>

<table class="table table-striped">
<thead>
    <tr>
        <th>
            Employee Id
        </th>
        <th>
            First Name
        </th>
        <th>
            Last Name
        </th>
        <th>
            Phone Number
        </th>
        <th>
            Address
        </th>
        <th>
            Email
        </th>
        <th>
            Date of Join
        </th>
        <th>
            Date of Birth
        </th>
        <th>
            Department
        </th>
        <th>
        </th>
    </tr>
</thead>
<tbody>
    <tr v-for="e in employees">
        <td>{{e.id}}</td>
        <td>{{e.firstName}}</td>
        <td>{{e.lastName}}</td>
        <td>{{e.phoneNumber}}</td>
        <td>{{e.address}}</td>
        <td>{{e.email}}</td>
        <td>{{e.dateOfJoin}}</td>
        <td>{{e.dateOfBirth}}</td>
        <td>{{e.departmentId}}</td>
        <td>
            <button type="button"
            class="btn btn-dark mr-1"
            data-bs-toggle="modal"
            data-bs-target="#exampleModal"
            @click="editClick(e)"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil" viewBox="0 0 16 16">
                <path d="M12.146.146a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1 0 .708l-10 10a.5.5 0 0 1-.168.11l-5 2a.5.5 0 0 1-.65-.65l2-5a.5.5 0 0 1 .11-.168l10-10zM11.207 2.5 13.5 4.793 14.793 3.5 12.5 1.207 11.207 2.5zm1.586 3L10.5 3.207 4 9.707V10h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.293l6.5-6.5zm-9.761 5.175-.106.106-1.528 3.821 3.821-1.528.106-.106A.5.5 0 0 1 5 12.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.468-.325z"/>
                </svg>
                </button>
                &nbsp
                <button type='button' class='btn btn-dark mr-1' @click="deleteClick(e)"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash3" viewBox="0 0 16 16">
                <path d="M6.5 1h3a.5.5 0 0 1 .5.5v1H6v-1a.5.5 0 0 1 .5-.5ZM11 2.5v-1A1.5 1.5 0 0 0 9.5 0h-3A1.5 1.5 0 0 0 5 1.5v1H2.506a.58.58 0 0 0-.01 0H1.5a.5.5 0 0 0 0 1h.538l.853 10.66A2 2 0 0 0 4.885 16h6.23a2 2 0 0 0 1.994-1.84l.853-10.66h.538a.5.5 0 0 0 0-1h-.995a.59.59 0 0 0-.01 0H11Zm1.958 1-.846 10.58a1 1 0 0 1-.997.92h-6.23a1 1 0 0 1-.997-.92L3.042 3.5h9.916Zm-7.487 1a.5.5 0 0 1 .528.47l.5 8.5a.5.5 0 0 1-.998.06L5 5.03a.5.5 0 0 1 .47-.53Zm5.058 0a.5.5 0 0 1 .47.53l-.5 8.5a.5.5 0 1 1-.998-.06l.5-8.5a.5.5 0 0 1 .528-.47ZM8 4.5a.5.5 0 0 1 .5.5v8.5a.5.5 0 0 1-1 0V5a.5.5 0 0 1 .5-.5Z"/>
                </svg>
            </button>
        </td>
    </tr>
</tbody>
</table>

<div class="modal fade" id="exampleModal" tabindex="-1"
    aria-labelledby="exampleModalLabel" aria-hidden="true">
<div class="modal-dialog modal-lg modal-dialog-centered">
<div class="modal-content">
    <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">{{modalTitle}}</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal"
        aria-label="Close"></button>
    </div>
    <div class="modal-body">
        <div class="input-group mb-3">
            <span class="input-group-text">First Name</span>
            <input type="text" class="form-control" v-model="firstName">
        </div>
        <div class="input-group mb-3">
            <span class="input-group-text">Last Name</span>
            <input type="text" class="form-control" v-model="lastName">
        </div>
        <div class="input-group mb-3">
            <span class="input-group-text">Phone Number</span>
            <input type="text" class="form-control" v-model="phoneNumber">
        </div>
        <div class="input-group mb-3">
            <span class="input-group-text">Address</span>
            <input type="text" class="form-control" v-model="address">
        </div>
        <div class="input-group mb-3">
            <span class="input-group-text">Email</span>
            <input type="text" class="form-control" v-model="email">
        </div>
        <div class="input-group mb-3">
            <span class="input-group-text">Date of Join</span>
            <input type="date" class="form-control" v-model="dateOfJoin">
        </div>
        <div class="input-group mb-3">
            <span class="input-group-text">Date of Birth</span>
            <input type="date" class="form-control" v-model="dateOfBirth">
        </div>
        <div class="input-group mb-3">
            <span class="input-group-text">Department Id</span>
            <input type="text" class="form-control" v-model="departmentId">
        </div>

        <button type="button" @click="createClick()"
        v-if="id==0" class="btn btn-primary" data-bs-dismiss="modal">
        Create
        </button>
        <button type="button" @click="updateClick()"
        v-if="this.id!=0" class="btn btn-primary" data-bs-dismiss="modal">
        Update
        </button>
    </div>
</div>
</div>
</div>


`,

data(){
    return{
        employees:[],
        modalTitle: "",
        id:0,
        firstName:"",
        lastName:"",
        phoneNumber:"",
        address:"",
        email:"",
        dateOfJoin:"",
        dateOfBirth:"",
        departmentId:0,
    };
},
methods:{
    refreshData(){
        axios.get(variables.API_URL+"employee")
        .then((response)=>{
            this.employees=response.data;
        });
    },
    addClick(){
        this.modalTitle="Add Employee";
        this.id=0;
        this.firstName="";
        this.lastName="";
        this.phoneNumber="";
        this.address="";
        this.email="";
        this.dateOfJoin="";
        this.dateOfBirth="";
        this.departmentId="";
    },
    editClick(e)
    {
        this.id=e.id;
        this.modalTitle="Edit Employee";
        this.firstName=e.firstName,
        this.lastName=e.lastName,
        this.phoneNumber=e.phoneNumber,
        this.address=e.address,
        this.email=e.email,
        this.dateOfJoin=e.dateOfJoin,
        this.dateOfBirth=e.dateOfBirth,
        this.departmentId=e.departmentId
    },
    createClick(){
        axios.post(variables.API_URL+"employee",
        {
            firstName:this.firstName,
            lastName:this.lastName,
            phoneNumber:this.phoneNumber,
            address:this.address,
            email:this.email,
            dateOfJoin:this.dateOfJoin,
            dateOfBirth:this.dateOfBirth,
            departmentId:this.departmentId
        })
        .then((response)=>{
            this.refreshData();
            alert("Created");
        });
    },
    updateClick(){
        axios.put(variables.API_URL+"employee/"+ this.id,{
            id:this.id,
            firstName:this.firstName,
            lastName:this.lastName,
            phoneNumber:this.phoneNumber,
            address:this.address,
            email:this.email,
            dateOfJoin:this.dateOfJoin,
            dateOfBirth:this.dateOfBirth,
            departmentId:this.departmentId
        })
        .then((response)=>{
            this.refreshData();
            alert("Updated");
        });
    },
    deleteClick(e){
        if(!confirm("Are you sure you want to delete?")){
            return;
        }
        axios.delete(variables.API_URL+"employee/"+ e.id)
        .then((response)=>{
            this.refreshData();
            alert("Deleted");
        })
    },
},
mounted:function(){
    this.refreshData();
},
}