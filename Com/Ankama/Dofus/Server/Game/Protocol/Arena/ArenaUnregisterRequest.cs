using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C0C RID: 3084
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaUnregisterRequest : IMessage<ArenaUnregisterRequest>, IMessage, IEquatable<ArenaUnregisterRequest>, IDeepCloneable<ArenaUnregisterRequest>, IBufferMessage
	{
		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x0600942D RID: 37933 RVA: 0x00275D74 File Offset: 0x00273F74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ArenaUnregisterRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x0600942E RID: 37934 RVA: 0x00275D84 File Offset: 0x00273F84
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

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x0600942F RID: 37935 RVA: 0x00275D94 File Offset: 0x00273F94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06009430 RID: 37936 RVA: 0x00275DA4 File Offset: 0x00273FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaUnregisterRequest()
		{
		}

		// Token: 0x06009431 RID: 37937 RVA: 0x00275DB4 File Offset: 0x00273FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaUnregisterRequest(ArenaUnregisterRequest other)
		{
		}

		// Token: 0x06009432 RID: 37938 RVA: 0x00275DC4 File Offset: 0x00273FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaUnregisterRequest Clone()
		{
			return null;
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x00275DD4 File Offset: 0x00273FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x00275DE4 File Offset: 0x00273FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaUnregisterRequest other)
		{
			return true;
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x00275DF4 File Offset: 0x00273FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009436 RID: 37942 RVA: 0x00275E04 File Offset: 0x00274004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009437 RID: 37943 RVA: 0x00275E14 File Offset: 0x00274014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009438 RID: 37944 RVA: 0x00275E24 File Offset: 0x00274024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009439 RID: 37945 RVA: 0x00275E34 File Offset: 0x00274034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600943A RID: 37946 RVA: 0x00275E44 File Offset: 0x00274044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaUnregisterRequest other)
		{
		}

		// Token: 0x0600943B RID: 37947 RVA: 0x00275E54 File Offset: 0x00274054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x00275E64 File Offset: 0x00274064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600943D RID: 37949 RVA: 0x00275E74 File Offset: 0x00274074
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaUnregisterRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					ArenaUnregisterRequest._parser = new MessageParser<ArenaUnregisterRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x0600943E RID: 37950 RVA: 0x00275F6C File Offset: 0x0027416C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PlXKWJJXgOaTFvprsYjY()
		{
			return true;
		}

		// Token: 0x0600943F RID: 37951 RVA: 0x00275F74 File Offset: 0x00274174
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaUnregisterRequest ARgBVhJXsTKRXAaT8dZ4()
		{
			return null;
		}

		// Token: 0x0400372C RID: 14124
		private static readonly MessageParser<ArenaUnregisterRequest> _parser;

		// Token: 0x0400372D RID: 14125
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400372E RID: 14126
		internal static ArenaUnregisterRequest K91t9KJXGVvPDp1sKNal;
	}
}
