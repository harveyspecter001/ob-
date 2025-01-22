using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Suggestion
{
	// Token: 0x0200010D RID: 269
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActivityHideRequest : IMessage<ActivityHideRequest>, IMessage, IEquatable<ActivityHideRequest>, IDeepCloneable<ActivityHideRequest>, IBufferMessage
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x001971A4 File Offset: 0x001953A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityHideRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x001971B4 File Offset: 0x001953B4
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

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x001971C4 File Offset: 0x001953C4
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

		// Token: 0x06000C47 RID: 3143 RVA: 0x001971D4 File Offset: 0x001953D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivityHideRequest()
		{
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x001971E4 File Offset: 0x001953E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivityHideRequest(ActivityHideRequest other)
		{
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x001971F4 File Offset: 0x001953F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ActivityHideRequest Clone()
		{
			return null;
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00197204 File Offset: 0x00195404
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x00197214 File Offset: 0x00195414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
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

		// Token: 0x06000C4C RID: 3148 RVA: 0x00197224 File Offset: 0x00195424
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00197234 File Offset: 0x00195434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ActivityHideRequest other)
		{
			return true;
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00197244 File Offset: 0x00195444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00197254 File Offset: 0x00195454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00197264 File Offset: 0x00195464
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00197274 File Offset: 0x00195474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00197284 File Offset: 0x00195484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00197294 File Offset: 0x00195494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ActivityHideRequest other)
		{
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x001972A4 File Offset: 0x001954A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x001972B4 File Offset: 0x001954B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x001972C4 File Offset: 0x001954C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ActivityHideRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				ActivityHideRequest._parser = new MessageParser<ActivityHideRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x001973BC File Offset: 0x001955BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HXve2HOcAqyW7cIEklYG()
		{
			return true;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x001973C4 File Offset: 0x001955C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ActivityHideRequest XEiqvlOcBgoNTM0xl4Ip()
		{
			return null;
		}

		// Token: 0x04000476 RID: 1142
		private static readonly MessageParser<ActivityHideRequest> _parser;

		// Token: 0x04000477 RID: 1143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000478 RID: 1144
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04000479 RID: 1145
		private int activityId_;

		// Token: 0x0400047A RID: 1146
		internal static ActivityHideRequest yCiTkHOcmoUSGdKJrbHC;
	}
}
