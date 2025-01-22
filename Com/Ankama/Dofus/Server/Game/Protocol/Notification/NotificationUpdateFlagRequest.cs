using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Notification
{
	// Token: 0x02000350 RID: 848
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NotificationUpdateFlagRequest : IMessage<NotificationUpdateFlagRequest>, IMessage, IEquatable<NotificationUpdateFlagRequest>, IDeepCloneable<NotificationUpdateFlagRequest>, IBufferMessage
	{
		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x001C48C4 File Offset: 0x001C2AC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<NotificationUpdateFlagRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x001C48D4 File Offset: 0x001C2AD4
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

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x001C48E4 File Offset: 0x001C2AE4
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

		// Token: 0x060027CE RID: 10190 RVA: 0x001C48F4 File Offset: 0x001C2AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationUpdateFlagRequest()
		{
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x001C4904 File Offset: 0x001C2B04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationUpdateFlagRequest(NotificationUpdateFlagRequest other)
		{
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x001C4914 File Offset: 0x001C2B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationUpdateFlagRequest Clone()
		{
			return null;
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060027D1 RID: 10193 RVA: 0x001C4924 File Offset: 0x001C2B24
		// (set) Token: 0x060027D2 RID: 10194 RVA: 0x001C4934 File Offset: 0x001C2B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
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

		// Token: 0x060027D3 RID: 10195 RVA: 0x001C4944 File Offset: 0x001C2B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x001C4954 File Offset: 0x001C2B54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NotificationUpdateFlagRequest other)
		{
			return true;
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x001C4964 File Offset: 0x001C2B64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x001C4974 File Offset: 0x001C2B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x001C4984 File Offset: 0x001C2B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x001C4994 File Offset: 0x001C2B94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x001C49A4 File Offset: 0x001C2BA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x001C49B4 File Offset: 0x001C2BB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NotificationUpdateFlagRequest other)
		{
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x001C49C4 File Offset: 0x001C2BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x001C49D4 File Offset: 0x001C2BD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x001C49E4 File Offset: 0x001C2BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NotificationUpdateFlagRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					NotificationUpdateFlagRequest._parser = new MessageParser<NotificationUpdateFlagRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x001C4AC8 File Offset: 0x001C2CC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Kj67goOh4YsnO9nBr2T2()
		{
			return true;
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x001C4AD0 File Offset: 0x001C2CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NotificationUpdateFlagRequest bL4ePgOhjMsshE3aMMY4()
		{
			return null;
		}

		// Token: 0x04000E2E RID: 3630
		private static readonly MessageParser<NotificationUpdateFlagRequest> _parser;

		// Token: 0x04000E2F RID: 3631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E30 RID: 3632
		public const int IndexFieldNumber = 1;

		// Token: 0x04000E31 RID: 3633
		private int index_;

		// Token: 0x04000E32 RID: 3634
		internal static NotificationUpdateFlagRequest BhD6mbOhxI30G52XUjfB;
	}
}
