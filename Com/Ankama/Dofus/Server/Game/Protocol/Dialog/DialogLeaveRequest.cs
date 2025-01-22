using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Dialog
{
	// Token: 0x020007E0 RID: 2016
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DialogLeaveRequest : IMessage<DialogLeaveRequest>, IMessage, IEquatable<DialogLeaveRequest>, IDeepCloneable<DialogLeaveRequest>, IBufferMessage
	{
		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x0600628A RID: 25226 RVA: 0x00223308 File Offset: 0x00221508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DialogLeaveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x0600628B RID: 25227 RVA: 0x00223318 File Offset: 0x00221518
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

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x0600628C RID: 25228 RVA: 0x00223328 File Offset: 0x00221528
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

		// Token: 0x0600628D RID: 25229 RVA: 0x00223338 File Offset: 0x00221538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DialogLeaveRequest()
		{
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x00223348 File Offset: 0x00221548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DialogLeaveRequest(DialogLeaveRequest other)
		{
		}

		// Token: 0x0600628F RID: 25231 RVA: 0x00223358 File Offset: 0x00221558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DialogLeaveRequest Clone()
		{
			return null;
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x00223368 File Offset: 0x00221568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x00223378 File Offset: 0x00221578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DialogLeaveRequest other)
		{
			return true;
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x00223388 File Offset: 0x00221588
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x00223398 File Offset: 0x00221598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x002233A8 File Offset: 0x002215A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x002233B8 File Offset: 0x002215B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x002233C8 File Offset: 0x002215C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x002233D8 File Offset: 0x002215D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DialogLeaveRequest other)
		{
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x002233E8 File Offset: 0x002215E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x002233F8 File Offset: 0x002215F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x00223408 File Offset: 0x00221608
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DialogLeaveRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					DialogLeaveRequest._parser = new MessageParser<DialogLeaveRequest>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x002234D4 File Offset: 0x002216D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BFBiv3OF762dKehbmNLp()
		{
			return true;
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x002234DC File Offset: 0x002216DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DialogLeaveRequest xWt0cTOFTTUwI5mjKdRM()
		{
			return null;
		}

		// Token: 0x040022A5 RID: 8869
		private static readonly MessageParser<DialogLeaveRequest> _parser;

		// Token: 0x040022A6 RID: 8870
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022A7 RID: 8871
		private static DialogLeaveRequest dd37iDOFQPgx6mCvIQC4;
	}
}
