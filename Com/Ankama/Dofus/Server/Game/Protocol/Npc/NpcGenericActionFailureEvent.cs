using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x02000335 RID: 821
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcGenericActionFailureEvent : IMessage<NpcGenericActionFailureEvent>, IMessage, IEquatable<NpcGenericActionFailureEvent>, IDeepCloneable<NpcGenericActionFailureEvent>, IBufferMessage
	{
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x001C2FA4 File Offset: 0x001C11A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<NpcGenericActionFailureEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x001C2FB4 File Offset: 0x001C11B4
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

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x001C2FC4 File Offset: 0x001C11C4
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

		// Token: 0x06002689 RID: 9865 RVA: 0x001C2FD4 File Offset: 0x001C11D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcGenericActionFailureEvent()
		{
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x001C2FE4 File Offset: 0x001C11E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcGenericActionFailureEvent(NpcGenericActionFailureEvent other)
		{
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x001C2FF4 File Offset: 0x001C11F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcGenericActionFailureEvent Clone()
		{
			return null;
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x001C3004 File Offset: 0x001C1204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x001C3014 File Offset: 0x001C1214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NpcGenericActionFailureEvent other)
		{
			return true;
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x001C3024 File Offset: 0x001C1224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x001C3034 File Offset: 0x001C1234
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x001C3044 File Offset: 0x001C1244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x001C3054 File Offset: 0x001C1254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x001C3064 File Offset: 0x001C1264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x001C3074 File Offset: 0x001C1274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NpcGenericActionFailureEvent other)
		{
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x001C3084 File Offset: 0x001C1284
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x001C3094 File Offset: 0x001C1294
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x001C30A4 File Offset: 0x001C12A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NpcGenericActionFailureEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					NpcGenericActionFailureEvent._parser = new MessageParser<NpcGenericActionFailureEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x001C3188 File Offset: 0x001C1388
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aKNnGDOWiUIpIgTE5qpw()
		{
			return true;
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x001C3190 File Offset: 0x001C1390
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NpcGenericActionFailureEvent W9oUbKOWP8ZgdmVQfgJV()
		{
			return null;
		}

		// Token: 0x04000DB1 RID: 3505
		private static readonly MessageParser<NpcGenericActionFailureEvent> _parser;

		// Token: 0x04000DB2 RID: 3506
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DB3 RID: 3507
		private static NpcGenericActionFailureEvent T2fdVOOWbb0e1P1f6yfg;
	}
}
