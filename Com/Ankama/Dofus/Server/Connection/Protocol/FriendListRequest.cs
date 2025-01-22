using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E41 RID: 3649
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendListRequest : IMessage<FriendListRequest>, IMessage, IEquatable<FriendListRequest>, IDeepCloneable<FriendListRequest>, IBufferMessage
	{
		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x0600AF34 RID: 44852 RVA: 0x002A10A8 File Offset: 0x0029F2A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendListRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x0600AF35 RID: 44853 RVA: 0x002A10B8 File Offset: 0x0029F2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x0600AF36 RID: 44854 RVA: 0x002A10C8 File Offset: 0x0029F2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AF37 RID: 44855 RVA: 0x002A10D8 File Offset: 0x0029F2D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListRequest()
		{
		}

		// Token: 0x0600AF38 RID: 44856 RVA: 0x002A10E8 File Offset: 0x0029F2E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListRequest(FriendListRequest other)
		{
		}

		// Token: 0x0600AF39 RID: 44857 RVA: 0x002A10F8 File Offset: 0x0029F2F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListRequest Clone()
		{
			return null;
		}

		// Token: 0x0600AF3A RID: 44858 RVA: 0x002A1108 File Offset: 0x0029F308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AF3B RID: 44859 RVA: 0x002A1118 File Offset: 0x0029F318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendListRequest other)
		{
			return true;
		}

		// Token: 0x0600AF3C RID: 44860 RVA: 0x002A1128 File Offset: 0x0029F328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AF3D RID: 44861 RVA: 0x002A1138 File Offset: 0x0029F338
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AF3E RID: 44862 RVA: 0x002A1148 File Offset: 0x0029F348
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AF3F RID: 44863 RVA: 0x002A1158 File Offset: 0x0029F358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AF40 RID: 44864 RVA: 0x002A1168 File Offset: 0x0029F368
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AF41 RID: 44865 RVA: 0x002A1178 File Offset: 0x0029F378
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendListRequest other)
		{
		}

		// Token: 0x0600AF42 RID: 44866 RVA: 0x002A1188 File Offset: 0x0029F388
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AF43 RID: 44867 RVA: 0x002A1198 File Offset: 0x0029F398
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AF44 RID: 44868 RVA: 0x002A11A8 File Offset: 0x0029F3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendListRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					FriendListRequest._parser = new MessageParser<FriendListRequest>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x0600AF45 RID: 44869 RVA: 0x002A1274 File Offset: 0x0029F474
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WmqqnlJvlFGYLj44vCua()
		{
			return true;
		}

		// Token: 0x0600AF46 RID: 44870 RVA: 0x002A127C File Offset: 0x0029F47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendListRequest ChFQuyJvcnqqDk6FAbII()
		{
			return null;
		}

		// Token: 0x04004096 RID: 16534
		private static readonly MessageParser<FriendListRequest> _parser;

		// Token: 0x04004097 RID: 16535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004098 RID: 16536
		private static FriendListRequest ixhaUPJvkq0iVAlY5rG1;
	}
}
