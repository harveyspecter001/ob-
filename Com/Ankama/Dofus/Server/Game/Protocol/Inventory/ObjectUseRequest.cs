using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003EA RID: 1002
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectUseRequest : IMessage<ObjectUseRequest>, IMessage, IEquatable<ObjectUseRequest>, IDeepCloneable<ObjectUseRequest>, IBufferMessage
	{
		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x001D244C File Offset: 0x001D064C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectUseRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x001D245C File Offset: 0x001D065C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x001D246C File Offset: 0x001D066C
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

		// Token: 0x06002F31 RID: 12081 RVA: 0x001D247C File Offset: 0x001D067C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseRequest()
		{
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x001D248C File Offset: 0x001D068C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseRequest(ObjectUseRequest other)
		{
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x001D249C File Offset: 0x001D069C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectUseRequest Clone()
		{
			return null;
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002F34 RID: 12084 RVA: 0x001D24AC File Offset: 0x001D06AC
		// (set) Token: 0x06002F35 RID: 12085 RVA: 0x001D24BC File Offset: 0x001D06BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x001D24CC File Offset: 0x001D06CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x001D24DC File Offset: 0x001D06DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectUseRequest other)
		{
			return true;
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x001D24EC File Offset: 0x001D06EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x001D24FC File Offset: 0x001D06FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x001D250C File Offset: 0x001D070C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x001D251C File Offset: 0x001D071C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x001D252C File Offset: 0x001D072C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x001D253C File Offset: 0x001D073C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectUseRequest other)
		{
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x001D254C File Offset: 0x001D074C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x001D255C File Offset: 0x001D075C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x001D256C File Offset: 0x001D076C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectUseRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_AC;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						continue;
					case 4:
						ObjectUseRequest._parser = new MessageParser<ObjectUseRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_AC:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
			}
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x001D263C File Offset: 0x001D083C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rcZ4BCO05Uecaho6NQgi()
		{
			return true;
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x001D2644 File Offset: 0x001D0844
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectUseRequest jZcUDxO0yhTXvesMpM72()
		{
			return null;
		}

		// Token: 0x0400109A RID: 4250
		private static readonly MessageParser<ObjectUseRequest> _parser;

		// Token: 0x0400109B RID: 4251
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400109C RID: 4252
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x0400109D RID: 4253
		private int objectUid_;

		// Token: 0x0400109E RID: 4254
		internal static ObjectUseRequest erccfUO0aGsrysVMgl7B;
	}
}
